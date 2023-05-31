Feature: Login Testing Form
    As a user
    I want to be able to login
    So that I can access the application

@login
Scenario: Successful login
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in


@invalid-login
Scenario: Login with invalid credentials
    Given I am on the invalid login page
    When I enter invalid email and password
    And I click the login button even 
    Then I should see an error message

