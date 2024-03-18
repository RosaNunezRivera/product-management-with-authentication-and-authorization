# Project Name & Description
Product Management with Authentication and Authorization

This project is a sample implementation of a product management system with authentication and authorization features.

## Installation Instruction
1. Clone the repository.
2. Navigate to the project directory.
3. Install dependencies using `npm install`.
4. Configure the database connection.
5. Run the application.

## Usage
1. Register or login to the system.
2. Navigate to the product management section.
3. Perform CRUD operations on products.

## Contributing Guidelines
1. Fork the repository.
2. Create a new branch.
3. Make your changes.
4. Test your changes.
5. Submit a pull request.

## License Information
This project is licensed under the MIT License. See the LICENSE file for more details.

## Documentacion
### HOME PAGE
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/bca7bbe9-e0b7-4495-a6f1-425dee7dafb9)

### REGISTER PAGE
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/05b01958-9d90-46c3-8801-b293e248d3fb)

### LOGIN PAGE
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/7d42ee95-2641-41fb-95ad-d22759ef6994)

### SINGLE PAGE APPLICATION 
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/1124e711-186d-4b7c-afb9-23ef0b6cd813)

### ADD PRODUCT 
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/a3523769-a8be-4c0a-a037-55566b3c9e17)

### CLIENT AND SERVER VALIDATION 
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/bd9e0da0-0687-4853-971b-000145f0e46f)

### DIALOG IN DELETE OPERATION
![image](https://github.com/RosaNunezRivera/product-management-with-authentication-and-authorization/assets/146019823/23208c52-3753-4927-8b28-730af25a8499)

## Project Structure
```
controllers/
ProductController.cs
models/
Product.cs
views/
Index.cshtml
```

## Testing Instructions
1. Run unit tests using your preferred testing framework.

## Contact Information
For any inquiries or support, please contact:
- Email: rosamarianunezrivera7@gmail.

## Acknowledgements
his project was solely created by the author Rosa Maria Nunez.

## Version History
- Version 1.0.0 (Feb, 2024): Initial release.

## Code Example for the Next Project Developed in Visual Studio Using AutoMapper
```csharp
// Import necessary namespaces
using PMSBLL;
using PMSDLL;
using ProductManagementWithAuthenticationAndAuthorization.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductManagementWithAuthenticationAndAuthorization.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public JsonResult GetProducts()
        {
            //Create the object ProductService
            ProductService productService = new ProductService();

            //Create a object productsColletion to store the products using product service and prodc repository
            var productsCollection = productService.GetProducts();

            //Create a Virtual Model List object
            List<ProductVM> productVMs = new List<ProductVM>();

            //Using Mapper to copy the object 
            productVMs = Mapper.Map<List<Product>, List<ProductVM>>(productsCollection);

            //Bring the result of the GetProducts() using Json 
            return Json(productVMs, JsonRequestBehavior.AllowGet);
        }

        // Other controller actions...
    }
}
```
