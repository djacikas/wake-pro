
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using Swashbuckle.AspNetCore.Filters;
using WakeProApi.Data;
using WakeProApi.Services;

namespace WakeProApi
{
   public class Program
   {
      public static void Main(string[] args)
      {
         var builder = WebApplication.CreateBuilder(args);

         builder.Services.AddControllers();
         // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
         builder.Services.AddEndpointsApiExplorer();
         builder.Services.AddSwaggerGen(options =>
         {
            options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
            {
               In = ParameterLocation.Header,
               Name = "Authorization",
               Type = SecuritySchemeType.ApiKey
            });

            options.OperationFilter<SecurityRequirementsOperationFilter>();
         });


         builder.Services.AddDbContext<UsersDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Users")));

         builder.Services.AddAuthorization();

         builder.Services.AddIdentityApiEndpoints<IdentityUser>()
            .AddEntityFrameworkStores<UsersDbContext>();


         var baseUrl = builder.Configuration.GetRequiredSection("ContentApi").GetValue<string>("BaseUrl");

         if (string.IsNullOrEmpty(baseUrl))
         {
            throw new Exception("BaseUrl is null or empty");
         }

         builder.Services.AddRefitClient<IContentClient>(
            new RefitSettings
            {
               ContentSerializer = new NewtonsoftJsonContentSerializer(
                  new JsonSerializerSettings
                  {
                     ContractResolver = new CamelCasePropertyNamesContractResolver(),
                     NullValueHandling = NullValueHandling.Include,
                  })
            })
            .ConfigureHttpClient(c =>
            {
               c.BaseAddress = new Uri(baseUrl);
               c.DefaultRequestHeaders.Add("Accept", "application/json");

            });

         var app = builder.Build();

         // Configure the HTTP request pipeline.
         if (app.Environment.IsDevelopment())
         {
            app.UseSwagger();
            app.UseSwaggerUI();
         }

         app.MapIdentityApi<IdentityUser>();

         app.UseHttpsRedirection();

         app.UseAuthorization();


         app.MapControllers();

         app.Run();
      }
   }
}
