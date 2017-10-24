#!groovy​
pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'DotNetRestore', defaultValue: true, description: 'Dotnet Restore')
        booleanParam(name: 'DotNetBuild', defaultValue: true, description: 'Dotnet Build')
        booleanParam(name: 'DotNetPublish', defaultValue: true, description: 'Dotnet Publish')

    }
    stages {
        stage('Restore') {
            steps {
                script {
                    if ("${params.DotNetRestore}" == "true") {
                        script {
                            bat """
								dotnet restore WakeboardUK.sln
							    """
                        }
                    } else {
                        echo "Skipped."
                    }
                }
            }

        }
        stage('Build') {
            steps {
                script {
                    if ("${params.DotNetBuild}" == "true") {
                        script {
                            bat """
								dotnet build WakeboardUK.sln
							    """
                        }
                    } else {
                        echo "Skipped."
                    }
                }
            }

        }
        stage('Publish') {
            steps {
                script {
                    if ("${params.DotNetPublish}" == "true") {
                        script {
                            bat """
                                cd WakeboardUK.Web
								dotnet publish WakeboardUK.Web.csproj --output ../output
							    """
                        }
                    } else {
                        echo "Skipped."
                    }
                }
            }

        }
    }
}
