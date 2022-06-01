Step 1: Add file with extension .yaml
Step 2: Config this file 
Step 3: Navigate to https://github.com/marketplace
Step 4: Search checkout, then setup-dotnet


Config file content:

name: Continous Integration and Deployment # name of process

on: # when process run
  push: 
    branches:
      - main 

jobs:
  build: 
    runs-on: ubuntu-latest
    steps: 
      - name: Check out code # just a name
        uses: actions/checkout@v3 # get from marketplace
      - name: Setup .NET 5
        uses: actions/setup-dotnet@v2
        with:
          dotnet-version: '5.0.x'

    
      

