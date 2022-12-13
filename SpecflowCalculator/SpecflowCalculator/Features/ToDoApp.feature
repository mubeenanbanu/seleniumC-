﻿Feature:ToDoApp
    Select first two items in the ToDoApp
    Enter new item to the ToDoApp
    Add the new item to the ToDoApp

 @ToDoApp
Scenario: Add items to the ToDoApp
    Given that I am on the LambdaTest Sample app 
    Then select the first item
    Then select the second item
    Then find the text box to enter the new value
    Then click the Submit button
    And verify whether the item is added to the list
    Then close the browser instance

