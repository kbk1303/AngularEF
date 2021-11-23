using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/**
 * This Context will migrate the following tables via Entity Framework to a Database called CarRegistrationDB
 * 
 * Table Car - Make and Model of a Car
 * Person - Person information
 * Registration - Information of first reg day, taxes
 * CheckUp - Holds information about next check-up
 * Ownership
 * 
 * Cardinality
 * 1-1: Car -> Registration. Car is principal entity. 
 * 1-n Car -> CheckUp. Car is principal entity. Holds a Foreignkey of CheckUp
 * n-m Ownership -> Car many to many relation. many cars can owned by many persons. Many persons can own many cars
 * 
 * 
*/

namespace AngularEF.DataRepository
{
    public class CarRegistrationContext: DbContext
    {
    }
}
