# Unit Testing with NUnit, xUnit, and MSTest

## Description

This project is a collection of examples and best practices for unit testing with three popular testing frameworks in C#: NUnit, xUnit, and MSTest. The code samples demonstrate how to write and run tests, create test fixtures and suites, use assertions, and mock dependencies.
The project is designed to help developers of all levels improve their unit testing skills and adopt a Test-Driven Development (TDD) approach. The code is organized by framework, with each framework containing multiple test cases and fixtures that cover a wide range of scenarios.


## Description

- Examples of how to use NUnit, xUnit, and MSTest for unit testing in C#
- Best practices for writing and running tests, creating fixtures and suites, and using assertions and mocks. Comprehensive coverage of
- common testing scenarios, such as testing exceptions, asynchronous code, and APIs.
- Easy-to-follow code samples with clear comments and explanations.
- Suitable for developers of all levels, from beginners to experts. Continuously updated with new test cases and frameworks.

## AAA in unit testing:
AAA in unit testing stands for "Arrange, Act, Assert". It is a common pattern used to structure unit tests in a clear and organized way, making them easier to understand and maintain. Each letter in the AAA pattern represents a phase of the unit test:

- Arrange: In this phase, you set up the necessary preconditions for the unit test. This may involve creating objects, setting up input data, or configuring the environment in which the test will run.

- Act: In this phase, you execute the code that you want to test. This may involve calling methods, invoking functions, or simulating user interactions.

- Assert: In this phase, you check the result of the code that you executed in the "Act" phase to see if it meets your expectations. This may involve comparing the actual result to an expected result, verifying that an exception was thrown, or checking the state of objects or variables.






# String Assertions with NUnit

- Assert.AreEqual: Assert.AreEqual("hello world", "Hello World", StringComparison.OrdinalIgnoreCase);
- Assert.Contains: Assert.Contains("world", "hello world");
- Assert.StartsWith: Assert.StartsWith("hello", "hello world");
- Assert.EndsWith: Assert.EndsWith("world", "hello world");
- Assert.IsMatch: Assert.IsMatch("[0-9]+", "12345");

These are just a few of the string assertion methods available in NUnit. There are many more that can be used to test various aspects of strings in unit tests.




