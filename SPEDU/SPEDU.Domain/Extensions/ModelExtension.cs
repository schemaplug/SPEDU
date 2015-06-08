using AutoMapper;
using SPEDU.Domain.BaseModels;

namespace SPEDU.Domain.Extensions
{
    public static class ModelExtension
    {
        public static TViewModel ConvertModelToViewModel<TModel, TViewModel>(this TModel model)
            where TViewModel : BaseModel
            where TModel : BaseModel
        {
            Mapper.CreateMap<TModel, TViewModel>();
            var viewModel = Mapper.Map<TModel, TViewModel>(model);
            return viewModel;
        }

        public static TModel ConvertViewModelToModel<TViewModel, TModel>(this TViewModel viewModel)
            where TViewModel : BaseModel
            where TModel : BaseModel
        {
            Mapper.CreateMap<TViewModel, TModel>();
            var model = Mapper.Map<TViewModel, TModel>(viewModel);
            return model;
        }

    }
}
