class Learning02
{
    public void Run()
    {
        Job job1 = new Job();
        job1._company.Set("Microsoft");
        job1._jobTitle.Set("Software Engineer");
        job1._startYear.Set(2019);
        job1._endYear.Set(2022);

        Job job2 = new Job();
        job2._company.Set("Apple");
        job2._jobTitle.Set("Manager");
        job2._startYear.Set(2022);
        job2._endYear.Set(2023);

        Resume resume = new Resume();
        resume._name.Set("Alison Rose");
        resume._jobs = new List<Job>();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
    }
}