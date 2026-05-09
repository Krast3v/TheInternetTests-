# TheInternetTests

Automated UI tests for [The Internet](https://the-internet.herokuapp.com) — a practice site for Selenium automation.

## Tech Stack
- C# / .NET 10
- Selenium WebDriver 4.43
- Selenium.Support 4.43
- NUnit 4.3
- ChromeDriver

## Project Structure
```
TheInternetTests/
  Pages/
    LoginPage.cs       # Page Object for login form
    DropdownPage.cs    # Page Object for dropdown
    CheckboxPage.cs    # Page Object for checkboxes
  LoginTests.cs        # Login success and failure scenarios
  DropdownTests.cs     # Dropdown selection tests
  CheckboxTests.cs     # Checkbox state and toggle tests
```

## Tests

### LoginTests.cs
| Test | Description |
|---|---|
| `SuccessfulLoginRedirectsToSecurePage` | Verifies redirect to /secure after valid login |
| `SuccessfulLoginShowsSuccessMessage` | Verifies success flash message |
| `InvalidPasswordShowsErrorMessage` | Verifies error message on wrong password |
| `InvalidUsernameShowsErrorMessage` | Verifies error message on wrong username |

### DropdownTests.cs
| Test | Description |
|---|---|
| `SelectOptionOneByText` | Selects Option 1 by visible text |
| `SelectOptionTwoByValue` | Selects Option 2 by value attribute |
| `CanSelectOption("Option 1")` | Parameterized selection test |
| `CanSelectOption("Option 2")` | Parameterized selection test |

### CheckboxTests.cs
| Test | Description |
|---|---|
| `FirstCheckboxIsUncheckedByDefault` | Verifies checkbox 1 is unchecked on load |
| `SecondCheckboxIsCheckedByDefault` | Verifies checkbox 2 is checked on load |
| `CanCheckFirstCheckbox` | Toggles checkbox 1 and verifies checked state |
| `CanUncheckSecondCheckbox` | Toggles checkbox 2 and verifies unchecked state |

## How to Run

```bash
dotnet test
```

## Key Concepts Demonstrated
- Page Object Model (POM)
- `SelectElement` for dropdown interaction
- `.Selected` property for checkbox state
- `WebDriverWait` with minimum element count condition
- `SendKeys()` for form input
- Flash message validation after form submit

## Author
Venelin Krustev — Junior QA Automation Engineer, Sofia
