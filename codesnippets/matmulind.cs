
        protected override void OnTick() 
        {
            if (running == true) 
            {   
                outputA.Ready = true;
                outputB.Ready = true;
                outputC.Ready = true;
                started = true;
                

               // Console.WriteLine($"i{i} j{j} k{k}");
                outputA.Addr = i * widthA + k;
                outputB.Addr = k * widthB + j;
                outputC.Addr = i * widthA + j;

                k++;

                if (k >= widthA)
                {
                    k = 0;
                    j++;
                }

                if (j >= widthB)
                {
                    j = 0;
                    i ++;
                }

                if (i >= heightA)
                {
                    running = false;
                }
            } 