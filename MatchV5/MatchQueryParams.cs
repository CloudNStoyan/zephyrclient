namespace Zephyr.MatchV5
{
    public class MatchQueryParams
    {
        public long? StartTime { get; set; }
        public long? EndTime { get; set; }
        public int? Queue { get; set; }
        public string? Type { get; set; }
        public int? Start { get; set; }
        public int? Count { get; set; }

        public string? ToUrlQuery()
        {
            var queries = new List<string>();

            if (this.StartTime.HasValue)
            {
                queries.Add("startTime=" + this.StartTime.Value);
            }

            if (this.EndTime.HasValue)
            {
                queries.Add("endTime="+ this.EndTime.Value);
            }

            if (this.Queue.HasValue)
            {
                queries.Add("queue=" + this.Queue.Value);
            }

            if (this.Type != null)
            {
                queries.Add("type=" + this.Type);
            }

            if (this.Start.HasValue)
            {
                queries.Add("start=" + this.Start);
            }

            if (this.Count.HasValue)
            {
                queries.Add("count=" + this.Count);
            }


            return queries.Count > 0 ? "?" + string.Join("&", queries) : null;
        }
    }
}
