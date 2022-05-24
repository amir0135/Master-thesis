
protected override void OnTick() {
    if (index.Ready) {
        if (flush.flg) {
            m_output.value = count + 1;
            count = 0;
        } else {
            count += 1;
        }
    }
}

protected override void OnTick() {
    if (index.Ready) {
        if (flush.flg) {
            m_output.value = accumulated + m_input.Data;
            accumulated = 0;
        } else {
            accumulated += m_input.Data;
        }
    }
}

protected override void OnTick() {
    if (index.Ready && flush.flg) {
        m_output.value = m_input.value /m_count.value;
        ind = index.Addr;
    }
}
    