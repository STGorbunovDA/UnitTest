namespace DeploymentItemAttributeSample
{
    public class MessageFromTemplate
    {
        public string TemplateFolder { get; set; }

        public string FromTemplate(string name, string level, DateTime creationTime)
        {
            string path = Path.Combine(TemplateFolder, "C:\\Users\\Dmitriy\\Desktop\\HomeWork\\С#\\UnitTest\\8_DeploymentItemAttributeSample\\DeploymentItemAttributeSample\\Templates\\ExamCreatedTemplate.txt");
            string template = File.ReadAllText(path);

            template = template.Replace("{Name}", name);
            template = template.Replace("{Level}", level);
            template = template.Replace("{DateAndTime}", creationTime.ToString("dd.MM.yyyy"));

            return template;
        }
    }
}