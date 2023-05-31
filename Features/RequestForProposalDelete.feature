Feature: RequestForProposalDelete

 As a user
  I want to delete a proposal request
  So that I can submit my proposaling requirements
Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in
 

@DeleteProposalRequest
  Scenario: Delete a proposal request
	Given I click on proposal Request Homepage
    When I clicked on Action to delete
    And I click on delete button
    And I click on Confirme Delete
    Then the proposal request should be Deleted successfully
