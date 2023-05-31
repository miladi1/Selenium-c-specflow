Feature: PurchaseRequestUpdateTestingForm
 As a user
  I want to update a purchase request
  So that I can submit my purchasing requirements

Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in

  @UpdatePurchase
  Scenario: Update a purchase request
    Given I click on Purchase Request
    When I click on Action
    And I click on edit
    And I update purchase 
    And I click on Save button to update
    Then the purchase request should be updated successfully
