    def forward(self, x):
        #savetxt('x_forward.csv', x, delimiter=',')
        hz, hr = self._forward_first_layer(x)
        z, r = self._forward_second_layers(hz, hr)
        y = self._combine_z_and_r(z, r)
        y = self._ensemble_predictions(y)
        return y