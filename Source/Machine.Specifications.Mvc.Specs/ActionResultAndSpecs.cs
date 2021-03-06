//-------------------------------------------------------------------------------------------------
// <auto-generated> 
// Marked as auto-generated so StyleCop will ignore BDD style tests
// </auto-generated>
//-------------------------------------------------------------------------------------------------

using Machine.Specifications.Mvc.Specs.ActionResults;

namespace Machine.Specifications.Mvc.Specs
{
    [Subject(typeof(ActionResultAnd<>))]
    public class when_the_action_result_and_is_asked_for_the_and_bit
    {
        static ActionResultAnd<TestActionResult> actionResultAnd;
        static TestActionResult actionResult;
        static TestActionResult result;

        Establish context = () =>
            {
                actionResult = new TestActionResult();
                actionResultAnd = new ActionResultAnd<TestActionResult>(actionResult);
            };

        Because of = () => result = actionResultAnd.And();

        It should_return_the_action_result = () => result.ShouldEqual(actionResult);
    }
}   