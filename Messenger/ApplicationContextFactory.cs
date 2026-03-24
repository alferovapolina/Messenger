using Messenger;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Messenger;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        var builder = new DbContextOptionsBuilder<ApplicationContext>();

        return new ApplicationContext(builder.Options);
    }

    public ApplicationContext CreateDbContext()
    {
        var builder = new DbContextOptionsBuilder<ApplicationContext>();

        return new ApplicationContext(builder.Options);
    }
}