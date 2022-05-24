
    input = File.ReadAllLines(CSVfile)
        .Where(x => !string.IsNullOrWhiteSpace(x))
        .Select(x => double.Parse(x.Trim(), CultureInfo.InvariantCulture))
        .ToArray();
}

public override async System.Threading.Tasks.Task Run()
{
    while (true)
    {
        await ClockAsync();
        output.Enabled = index.Ready;
        if (index.Ready)
        {
            output.Address = index.Addr;
            output.Data = input[index.Addr];
        }
    }
}
