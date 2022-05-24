    def _forward_first_layer(self, x):
        batchsize = x.shape[0]
        h = x.mm(self.W0.reshape(self.num_networks * self.hidden_size, self.input_size).t())
        h = h.reshape(batchsize, self.num_networks, self.hidden_size)
        hz = self.prelu_z_slopes[None, :, None] * h * (h < 0) + h * (h >= 0)  # parametric relu
        hr = self.prelu_r_slopes[None, :, None] * h * (h < 0) + h * (h >= 0)  # parametric relu
        return hz, hr    
            
    def _forward_second_layers(self, hz, hr):
        #dual second layer linear transformations
        z = (hz * self.Wz[None]).sum(axis=-1)
        r = (hr * self.Wr[None]).sum(axis=-1)
        return z, r    
        
    def _combine_z_and_r(self, z, r):
        z = 2.0 * torch.sigmoid(self.z_scale[None] * z) - 1.0
        r = F.softplus(r)
        return r * z    

    def _ensemble_predictions(self, y):
        y = y.clamp(-self.max_predict, self.max_predict) # clip prediction of each network
        y = y.mean(axis=-1) # average over networks
        return y