using Training_Management.Context;
using Training_Management.Models;

namespace Training_Management.Repository
{
    public class BatchRepository : BatchInterface
    {

        TrainingDbContext _db;

        public BatchRepository(TrainingDbContext db)
        {
            _db = db;
        }

        public Batch Create(Batch batch)
        {
            _db.Batches.Add(batch);
            _db.SaveChanges();
            return batch;
        }

        public int Edit(int id, Batch batch)
        {
            Batch obj = GetBatchById(id);
            if (obj != null)
            {
                foreach (Batch temp in _db.Batches)
                {
                    if (temp.BatchId == id)
                    {
                        temp.BatchName = batch.BatchName;
                        temp.StartDate = batch.StartDate;
                        temp.Trainer = batch.Trainer;
                       temp.Course= batch.Course;


                    }
                }
                _db.SaveChanges();
                return 0;
            }
            else

                return 1;
        }

        public Batch GetBatchById(int id)
        {
            return _db.Batches.FirstOrDefault(x => x.BatchId == id);
        }

        public List<Batch> GetBatches()
        {
            return _db.Batches.ToList();
        }

        public List<BatchViewModel> GetBatche()
        {
            var list = (
            from batch in _db.Batches
            join course in _db.Courses
            on batch.Course.CourseId
            equals course.CourseId
            select new BatchViewModel
            {
                Id = batch.BatchId,
                BatchName = batch.BatchName,
                Trainer = batch.Trainer,
                CourseName = course.CourseName,
                Description = course.Description,
                StartDate = batch.StartDate,
            }).ToList();
            return list;
            //return _db.Batchs.ToList();
        }
    }
}
