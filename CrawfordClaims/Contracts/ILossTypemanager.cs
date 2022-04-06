namespace CrawfordClaims
{
    public interface ILossTypemanager
    {
        public LossType GetLossType(int id);

        public LossType[] GetLossTypes();

        public void AddLossType(LossType losstype);

        public void UpdateLossType(LossType losstype);

        public void DeleteLossType(int id);
    }
}
