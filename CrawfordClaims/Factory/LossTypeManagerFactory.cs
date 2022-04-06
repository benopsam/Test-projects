namespace CrawfordClaims
{
    public class LossTypeManagerFactory
    {
        public ILossTypemanager GetLossTypeManager()
        {
            return new SqlLosstypeManager();
        }
    }
}
