using System.ComponentModel;

public class Product
{

    public BindingList<Part> AssociatedParts { get; set; }
    public int ProductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int InStock { get; set; }
    public int Min { get; set; }
    public int Max { get; set; }

    public Product()
    {
        AssociatedParts = new BindingList<Part>();
    }

    public void addAssociatedPart(Part part)
    {
        AssociatedParts.Add(part);
    }

    public bool removeAssociatedPart(int partID)
    {
        Part part = lookupAssociatedPart(partID);

        if (part != null)
        {
            AssociatedParts.Remove(part);
            return true;
        }
        return false;
    }
    public Part lookupAssociatedPart(int partID)
    {
        foreach (Part part in AssociatedParts)
        {
            if (part.PartID == partID)
            {
                return part;
            }
        }

        return null;
    }
}