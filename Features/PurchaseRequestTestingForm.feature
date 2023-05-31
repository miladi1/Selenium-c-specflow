Feature: Purchase Request
 As a user
  I want to create a purchase request
  So that I can submit my purchasing requirements
Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in
 
  @createPurchase
  Scenario: Create a purchase request
    Given I click on Purchase Requests
    When I click on Create button
    And I enter the title
    And I select the requester 
    And I enter the deadline 
    And I check the Completed checkbox
    And I click on Save button
    Then the purchase request should be saved successfully
