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
    LoginPage.cs             # Page Object for login form
    DropdownPage.cs          # Page Object for dropdown
    CheckboxPage.cs          # Page Object for checkboxes
    AlertPage.cs             # Page Object for JS alerts
    DynamicLoadingPage.cs    # Page Object for dynamic content
  LoginTests.cs              # Login success and failure scenarios
  DropdownTests.cs           # Dropdown selection tests
  CheckboxTests.cs           # Checkbox state and toggle tests
  AlertTests.cs              # JS alert, confirm and prompt tests
  DynamicLoadingTests.cs     # Explicit wait for delayed elements
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

### AlertTests.cs
| Test | Description |
|---|---|
| `AlertShowsCorrectText` | Verifies alert text before accepting |
| `AcceptingAlertShowsResult` | Accepts JS alert and verifies result |
| `AcceptingConfirmShowsResult` | Accepts confirm dialog and verifies result |
| `DismissingConfirmShowsResult` | Dismisses confirm dialog and verifies result |
| `PromptAcceptsTypedText` | Types text in prompt and verifies result |

### DynamicLoadingTests.cs
| Test | Description |
|---|---|
| `Example1ShowsHelloWorldAfterLoad` | Waits for hidden element to become visible |
| `Example2ShowsHelloWorldAfterLoad` | Waits for element added to DOM after delay |

## How to Run

```bash
dotnet test
```

## Key Concepts Demonstrated
- Page Object Model (POM)
- `SelectElement` for dropdown interaction
- `.Selected` property for checkbox state
- `WebDriverWait` with explicit conditions
- `driver.SwitchTo().Alert()` for JS alerts
- `Displayed` property for dynamic element visibility
- `SendKeys()` for form input and prompt dialogs
- XPath by text: `//button[text()='...']`

## Author
Venelin Krustev — Junior QA Automation Engineer, Sofia
