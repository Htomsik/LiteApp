﻿using AppInfrastructure.Services.StoreServices.Parametrize;
using AppInfrastructure.Stores.DefaultStore;
using AppInfrastructureTests.ServicesTests.IParametrizeNavigationServiceTests.Base;

namespace AppInfrastructureTests.ServicesTests.IParametrizeNavigationServiceTests.Navigation;

[TestClass]
public class BaseLazyParamNavigationServiceTests :BaseAbstractLazyParamNavigationService<BaseLazyStore<object>,BaseLazyParamNavigationService<object,object>,object,object>
{
    
    protected override object GenerateInputValue() => "Input";
    
    protected override object GenerateOutputValue() => "Output";

    protected override BaseLazyStore<object> GenerateStore() => new();

    protected override BaseLazyParamNavigationService<object, object> GenerateService(IStore<object> store,
        Func<object, object> action) => new(store,action);

}