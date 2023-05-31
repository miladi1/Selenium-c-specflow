Feature: PurchaseRequestDeleteTestingForm
 As a user
  I want to delete a purchase request
  So that I can submit my purchasing requirements
Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in
 

@DeletePurchaseRequest
  Scenario: Delete a purchase request
	Given I click on Purchase Request Homepage
    When I clicked on Action
    And I click on delete
    And I click on Confirm Delete
    Then the purchase request should be Deleted successfully
 