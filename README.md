[![Continous Integration and Deployment](https://github.com/nguyentruonggiang210/AspNet-Live-CICD/actions/workflows/ci-cd.yaml/badge.svg)](https://github.com/nguyentruonggiang210/AspNet-Live-CICD/actions/workflows/ci-cd.yaml)

Step 1: Add file .gitignore to prevent commit some files
Step 2: Add file with extension .yaml
Step 3: Config this file 
Step 4: Navigate to https://github.com/marketplace
Step 5: Search checkout, then setup-dotnet
Step 6: Deploy azure web app
+ Navigate to Azure Portal
+ Add AppService
+ Click "Get publish profile"
+ Go to github repo, tab "Settings"
+ Secret > Action Secrets and create new with value is file content downloaded
+  Config yaml file
    
Note:
dotnet restore : fetch necessary packages

dotnet build -c Release --no-restore : build solution with options: Release mode and no restore again
