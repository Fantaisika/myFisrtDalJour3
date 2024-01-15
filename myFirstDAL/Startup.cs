using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using myFirstDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstDAL
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();//ajout des controllers et views (1)
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();//(2)
            app.UseRouting();

            using (BddContext ctx = new BddContext () ) //(4) connexion a la base de données
            {
                ctx.InitializeDb();//initialiser notre bdd

            }// dès qu'on fini d'utiliser la base de données ou dès qu'on appli de fermer l'accès a la bdd (save changes) il fait appel a context.dispose pour le nettoyage 

            app.UseEndpoints(endpoints => //(exemple d'ajout d'une autre route)
            {

                endpoints.MapControllerRoute(
                name: "example",
                pattern: "Votes/{ajouterVotes}/{UpdateVotes}/{nomUtilisateur}/{idSejour}");  

            });

            app.UseEndpoints(endpoints => //(3)
            {

                endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");  // la forme que allait avoir notre differente route , mettre en dernier le parttern par defaut

            });
        }
    }
}
