using System.ComponentModel;

public class Inventory

{
    public BindingList<Product> Products { get; set; }
    public BindingList<Part> AllParts { get; set; }

    public Inventory()
    {
        Products = new BindingList<Product>();
        AllParts = new BindingList<Part>();
    }

    public void addProduct(Product product)
    {
        Products.Add(product);
    }

    public bool removeProduct(int productID)
    {
        Product product = lookupProduct(productID);

        if (product != null)
        {
            Products.Remove(product);
            return true;
        }

        return false;
    }

    public Product lookupProduct(int productID)
    {
        foreach (Product product in Products)
        {
            if (product.ProductID == productID)
            {
                return product;
            }
        }

        return null;
    }

    public void updateProduct(int productID, Product updatedProduct)
    {
        Product existingProduct = lookupProduct(productID);

        if (existingProduct != null)
        {
            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.InStock = updatedProduct.InStock;
            existingProduct.Min = updatedProduct.Min;
            existingProduct.Max = updatedProduct.Max;
            existingProduct.AssociatedParts = updatedProduct.AssociatedParts;
        }
    }

    public void addPart(Part part)
    {
        AllParts.Add(part);
    }

    public bool deletePart(Part part)
    {
        if (part != null && AllParts.Contains(part))
        {
            AllParts.Remove(part);
            return true;
        }
        return false;
    }

    public Part lookupPart (int partID)
    {
        foreach (Part part in AllParts)
        {
            if (part.PartID == partID)
            {
                return part;
            }
        }
        return null;
    }

    public void updatePart (int partID, Part updatedPart)
    {
        Part existingPart = lookupPart(partID);

        if (existingPart != null)
        {
            int index = AllParts.IndexOf(existingPart);

            AllParts[index] = updatedPart;
        }
    }
}