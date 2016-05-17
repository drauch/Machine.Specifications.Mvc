//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

namespace Machine.Specifications.Mvc.Specs
{
    using System;

    [Subject(typeof(ControllerExtensions))]
    public class when_the_controller_extensions_is_asked_for_the_controller_routing_name
    {
        static string result;

        Because of = () => result = new HomeController().RoutingName();

        It should_return_the_name_of_the_controller_minus_the_word_controller = () => result.ShouldEqual("Home");
    }

    [Subject(typeof(ControllerExtensions))]
    public class when_the_controller_extensions_is_asked_for_the_controller_routing_name_and_the_controller_does_not_end_in_the_word_controller
    {
        static Exception exception;

        Because of = () => exception = Catch.Exception(() => new HomeControllerNonStandard().RoutingName());

        It should_throw_an_exception = () => exception.ShouldBeAssignableTo<SpecificationException>();
    }

    [Subject(typeof(ControllerExtensions))]
    public class when_the_controller_extensions_is_asked_for_the_controller_routing_name_and_the_controller_is_just_called_controller
    {
        static Exception exception;

        Because of = () => exception = Catch.Exception(() => new Controller().RoutingName());

        It should_throw_an_exception = () => exception.ShouldBeAssignableTo<SpecificationException>();
    }

    internal class HomeControllerNonStandard : Controller
    {
    }

    internal class Controller : System.Web.Mvc.Controller
    {
        
    }
}   