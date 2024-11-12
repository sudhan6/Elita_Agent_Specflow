Feature: Login Page Functionality

  Scenario: Successful Login
    Given the user is on the Login Page
    When the user enters valid username and password
    And the user clicks on the login button
    Then the user is redirected to the Home Page

  Scenario: Unsuccessful Login with Invalid Credentials
    Given the user is on the Login Page
    When the user enters an invalid username or password
    And the user clicks on the login button
    Then an error message 'invalid credentials' is displayed