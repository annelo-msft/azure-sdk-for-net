param (
    [hashtable] $DeploymentOutputs,
    [string] $TenantId,
    [string] $TestApplicationId,
    [string] $TestApplicationSecret
)

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v1' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v2' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v3' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v4' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v5' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v6' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v7' -Mode 'Force'

Import-AzContainerRegistryImage `
    -ResourceGroupName $DeploymentOutputs['CONTAINERREGISTRY_RESOURCE_GROUP'] `
    -RegistryName $DeploymentOutputs['CONTAINERREGISTRY_USERNAME'] `
    -SourceImage 'library/hello-world' -SourceRegistryUri 'registry.hub.docker.com' `
    -TargetTag 'v8' -Mode 'Force'

