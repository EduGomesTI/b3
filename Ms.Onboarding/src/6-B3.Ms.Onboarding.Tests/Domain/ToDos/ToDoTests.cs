using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Onboarding.Domain.DomainExceptions;
using B3.Ms.Onboarding.Domain.Extensions;
using FluentAssertions;

namespace B3.Ms.Onboarding.Tests.Domain.ToDos
{
    public class ToDoTests
    {

        #region Properties

        private const string Description = "Test Description";
        private const int New = 1;
        private const int Planned = 2;
        private const int InProgress = 3;
        private const int Done = 4;
        private const int FailStatus = 5;

        #endregion

        #region Constructors



        #endregion

        #region Tests

        [Fact(DisplayName = "Create Date Should Be Set Successfuly")]
        [Trait("ToDoTests", "Success")]
        public void CreateDateShouldBeSetSuccessfuly()
        {
            var toDo = new ToDo(Description);

            toDo.CreateDate.Date.Should().Be(DateTime.Now.Date);
        }

        [Fact(DisplayName = "Change Description Successfuly")]
        [Trait("ToDoTests", "Success")]
        public void ChangeDescriptionSuccessfuly()
        {
            var toDo = ToDo();

            toDo.Description.Should().Be(Description);
        }

        [Fact(DisplayName = "Change Description Should fail")]
        [Trait("ToDoTests", "Fail")]
         public void ChangeDescriptionShouldFail()
        {
            static void action()
            { _ = new ToDo(string.Empty); }

            DomainException exception = Assert.Throws<DescriptionEmptyInvalidException>(action);

            exception.Message.Should().Be("Deve ser informado uma descrição válida");
        }

        [Fact(DisplayName = "Status Should Not Be Set To New")]
        [Trait("ToDoTests", "Success")]
        public void StatusShouldNotBeSetToNew()
        {
            var toDo = ToDo(Description);

            toDo.ChangeStatus(New);

            toDo.Messages.Should().Contain("Esta tarefa já está com o status de Nova Tarefa");            
        }

        [Fact(DisplayName = "Status Should Be Set To Planned")]
        [Trait("ToDoTests", "Success")]
        public void StatusShouldBeSetToPlanned()
        {
            var toDo = ToDo(Description);

            toDo.ChangeStatus(Planned);

            toDo.Status.GetDisplayName().Should().Be("Tarefa Planejada");
        }

        [Fact(DisplayName = "Status Should Be Set To InProgress")]
        [Trait("ToDoTests", "Success")]
        public void StatusShouldBeSetToInProgress()
        {
            var toDo = ToDo(Description);

            toDo.ChangeStatus(InProgress);

            toDo.Status.GetDisplayName().Should().Be("Tarefa em Andamento");
        }

        [Fact(DisplayName = "Status Should Be Set To Done")]
        [Trait("ToDoTests", "Success")]
        public void StatusShouldBeSetToDone()
        {
            var toDo = ToDo(Description);

            toDo.ChangeStatus(Done);

            toDo.Status.GetDisplayName().Should().Be("Tarefa Concluída");

            toDo.ConclusionDate.Date.Should().Be(DateTime.Now.Date);
        }

        [Fact(DisplayName = "Status Should Be Fail With Other Option")]
        [Trait("ToDoTests", "Fail")]
        public void StatusShouldBeFailWithOtherOption()
        {
            var toDo = ToDo(Description);

            toDo.ChangeStatus(FailStatus);

            toDo.Messages.Should().Contain("Opção de status inválida");

          
        }

        #endregion

        #region Methods

        private static ToDo ToDo(string description = Description)
        {
            var id = 1;

            return new ToDo(id, description);
        }

        #endregion
    }
}
