# CPH_DesignByContract

created a program there is using our created accout class with a deposiet and withdraw method
the program use the contract exstansion to check the requerments.
the precondition for the 2 method is that amount must be positive
and for the withdraw is a second precondition that the amount must not exceed the balance

by using Contract.requirement we can test if the precondition is meet, if not it will throw an exception

we test the program by giving it 0 or a negative number, and an amount bigger than the balance and the program throw the exception.
will the program worked as it should with the positive numbers and an amount less than the balance.
