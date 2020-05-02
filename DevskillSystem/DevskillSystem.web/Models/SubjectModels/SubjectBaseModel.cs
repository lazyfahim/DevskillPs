using Autofac;
using DevSkillSystem.FrameWork;

namespace DevskillSystem.web.Models.SubjectModels
{
    public class SubjectBaseModel
    {
        internal ISubjectService _subjectService;

        public SubjectBaseModel(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        public SubjectBaseModel()
        {
            _subjectService = Startup.AutofacContainer.Resolve<ISubjectService>();
        }
    }
}