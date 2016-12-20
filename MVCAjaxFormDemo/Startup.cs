using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAjaxFormDemo.Startup))]
namespace MVCAjaxFormDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            
        }
    }
}
