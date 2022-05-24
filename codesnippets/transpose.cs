protected override void OnTick()
{
    if (running == true)
    {
        started = true;
        j++;
        if (j >= height)
        {
            j = 0;
            i++;
        }
        outputA.Addr = i * height + j;
        outputB.Addr = j * width + i;
        if (i >= width - 1 && j >= height - 1)
        {
            running = false;
        }
    }
    else
    {
        if (controlA.Ready == true)
        {
            started = true;
            running = true;
            width = controlA.Width;
            height = controlA.Height;
            i = j = 0;
            outputA.Ready = true;
            outputB.Ready = true;
        }
        else
        {
            if (started == true)
            {
                controlout.Ready = true;
                controlout.Height = controlA.Height;
                controlout.Width = controlA.Width;
                controlout.OffsetA = controlA.OffsetA;
                controlout.OffsetB = controlA.OffsetB;
                started = false;
            }
            else
            {
                controlout.Ready = false;
            }
            outputA.Ready = false;
            outputB.Ready = false;
        }
    }
}