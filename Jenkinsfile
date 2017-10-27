#!groovy​
pipeline {
    agent {
        label 'win'
    }
    parameters {
        booleanParam(name: 'Restore', defaultValue: true, description: 'Dotnet Restore')
        booleanParam(name: 'Build', defaultValue: true, description: 'Dotnet Build')
        booleanParam(name: 'Publish', defaultValue: true, description: 'Dotnet Publish')
    }
    stages {
        stage('Restore') {
            when { expression { params.Restore == true } }
            steps {
                script {
                    bat """
								dotnet restore WakeboardUK.sln
							    """
                }
            }
        }
    }
    stage('Build') {
        steps {
            script {
                if ("${params.Build}" == "true") {
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
                if ("${params.Publish}" == "true") {
                    script {
                        bat """
                                cd WakeboardUK.Web
								dotnet publish WakeboardUK.Web.csproj --framework netcoreapp1.1 -o ..\\Publish\\WakeboardUK.Web
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
