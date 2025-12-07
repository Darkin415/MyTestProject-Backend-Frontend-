namespace DocumentService.Domain;

public class Document
{
    //efCore
    private Document()
    {
        
    }

    public Document(Guid id, string name, string description, string filePath, DateTime createAt, DateTime updateAt)
    {
         Id = id;
         Name = name;
         Description = description;
         FilePath = filePath;
         CreateAt = DateTime.UtcNow;
         UpdateAt = CreateAt;
         IsDeleted = false;
    }
    public Guid Id { get; private set; }
    
    public string Name { get; private set; }
    
    public string Description { get; private set; }
    
    public string FilePath { get; private set; }
    
    public bool IsDeleted { get; private set; }
    
    public DateTime CreateAt { get; private set; }
    
    public DateTime UpdateAt { get; private set; }
}