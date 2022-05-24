protected override void OnTick(){
    if (index.Ready == true){
        if (index.Addr == ind){
            accumulated += m_input.Data;
            m_output.value = accumulated /count;
            count += 1;                   
        }
        else{
            m_output.value = accumulated /count;
            accumulated = m_input.Data;
            count = 1;
            ind = index.Addr;
        }   
    }
}  