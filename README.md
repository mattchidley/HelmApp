Instructions:

1) create a dockerfile for the dotnet 8.0 web api "HelmApp"

2) create a helmchart with two separate workloads with one container in each
- one with Environment variable `ENV_CONFIG` set to "Helm Pod A"
- one with Environment variable `ENV_CONFIG` set to "Helm Pod B"

3) setup necessary resources to route web traffic into the cluster
- /a sends requests to Helm Pod A
- /b sends request to Helm Pod B
