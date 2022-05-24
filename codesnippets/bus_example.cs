        public interface IndexValue : IBus {
        [InitialValue(false)]
                bool Ready { get; set;} 
                int Addr { get; set; }
        }