using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.SubjectModels
{
    public class SubjectCreateModel:SubjectBaseModel
    {
        public SubjectCreateModel(ISubjectService subjectService)
            :base(subjectService){}

        public SubjectCreateModel() : base()
        {
        }
        public string Name { get; set; }
        public bool RegistrationOpen { get; set; }
        public void CreateSubject()
        {
            Subject subject = new Subject
            {
                Name = this.Name,
                RegistrationOpen = this.RegistrationOpen
            };
            _subjectService.AddSubject(subject);
        }
        
    }
}