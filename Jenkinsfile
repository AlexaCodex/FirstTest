node {
def msbuild = tool name: 'MSBuild', type: 'hudson.plugins.msbuild.MsBuildInstallation'

	stage ('Checkout'){
				checkout scm
			}
	//stage('Build') {
	//			bat "${msbuild} FirstTest.sln"
	//			}
}

input message: "Does staging look good?"
try {
    checkpoint('Before production')
} catch (NoSuchMethodError _) {
    echo 'Checkpoint feature available in CloudBees Jenkins Enterprise.'
}
