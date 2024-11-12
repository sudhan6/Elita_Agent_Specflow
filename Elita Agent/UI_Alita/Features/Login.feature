Feature: Login Functionality
  As a user, I want to log in to the application so that I can access the product page.

  Scenario Outline: Successful login with multiple users
    Given I am on the login page
    When I enter '<username>' and '<password>'
    And I click the login button
    Then I should be redirected to the product page
    And I logout

    Examples:
      | username             | password    |
      | standard_user        | secret_sauce |
      | locked_out_user      | secret_sauce |
      | problem_user         | secret_sauce |
      | performance_glitch_user | secret_sauce |

  Scenario: Unsuccessful login attempt
    Given I am on the login page
    When I enter 'invalid_user' and 'invalid_password'
    And I click the login button
    Then I should see an error message indicating login failure