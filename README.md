# Calculator demo (.NET 8 + xUnit + GitHub Actions)

A tiny console app with unit tests and a CI pipeline, made for practicing GitHub Actions.

## Folder layout

```
CalculatorDemo/
├── CalculatorDemo.sln                  <- open this in Visual Studio
├── src/CalculatorApp/                  <- the console app
│   ├── Calculator.cs                   <- the logic being tested
│   └── Program.cs                      <- reads input, prints results
├── tests/CalculatorApp.Tests/          <- the unit tests (xUnit)
│   └── CalculatorTests.cs
└── .github/workflows/ci.yml            <- the GitHub Actions pipeline
```

## Run it on your laptop

You need the .NET 8 SDK: https://dotnet.microsoft.com/download

```
dotnet run --project src/CalculatorApp
dotnet test
```

## Push to GitHub and watch CI run

1. Create a new empty repository on github.com (no README).
2. In this folder, run:

```
git init
git add .
git commit -m "Calculator app with tests and CI"
git branch -M main
git remote add origin https://github.com/<your-username>/<repo-name>.git
git push -u origin main
```

3. Open the repository on GitHub and click the **Actions** tab. The `ci` workflow runs and shows a green tick when all tests pass.

## Try a failing build

Change `a + b` to `a - b` in `Calculator.cs`, push again, and watch the pipeline turn red. Revert it and it goes green again. That is CI doing its job.
