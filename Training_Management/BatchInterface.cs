using Training_Management.Models;

namespace Training_Management
{
    public interface BatchInterface
    {

        List<Batch> GetBatches();
        Batch Create(Batch batch);
        Batch GetBatchById(int id);
        int Edit(int id, Batch batch);

        List<BatchViewModel> GetBatche();
    }
}
