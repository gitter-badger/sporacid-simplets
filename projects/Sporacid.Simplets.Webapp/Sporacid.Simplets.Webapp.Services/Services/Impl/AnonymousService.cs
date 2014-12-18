﻿namespace Sporacid.Simplets.Webapp.Services.Services.Impl
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;
    using Sporacid.Simplets.Webapp.Services.Database.Dto;

    /// <authors>Simon Turcotte-Langevin, Patrick Lavallée, Jean Bernier-Vibert</authors>
    /// <version>1.9.0</version>
    [RoutePrefix("api/v1/anonymous")]
    public class AnonymousService : BaseService, IAnonymousService
    {
        /// <summary>
        /// Dummy method that can be called to bootstrap a new user.
        /// </summary>
        [HttpGet]
        [Route("noop")]
        public void NoOp()
        {
        }

        /// <summary>
        /// Help method to get the api help.
        /// </summary>
        [HttpGet]
        [Route("help")]
        public IEnumerable<ApiMethodDescriptionDto> Help()
        {
            var apiDescriptions = GlobalConfiguration.Configuration.Services.GetApiExplorer().ApiDescriptions;
            return apiDescriptions.Select(apiDescription => new ApiMethodDescriptionDto
            {
                Documentation = apiDescription.Documentation,
                HttpMethod = apiDescription.HttpMethod.Method,
                Route = apiDescription.Route.RouteTemplate,
                ParameterDescriptions = apiDescription.ParameterDescriptions.Select(parameterDescription => new ApiMethodParameterDescriptionDto
                {
                    Name = parameterDescription.Name,
                    Documentation = parameterDescription.Documentation,
                    ParameterType = parameterDescription.ParameterDescriptor.ParameterType.Name,
                    IsOptional = parameterDescription.ParameterDescriptor.IsOptional
                })
            });
        }
    }
}