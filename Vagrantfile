# -*- mode: ruby -*-
# vi: set ft=ruby :
# This Dev Machine Vagrantfile was generated by Devmachine.io
# Visit the machine definition at http://devmachine.io/machines/details/142)
Vagrant.configure(2) do |config|

    # Vagrant Box
   config.vm.box = "mwrock/Windows2012R2"

   # Remote Desktop
   config.vm.communicator = "winrm"
   config.vm.network :forwarded_port,
       host: 33389,
       guest: 3389,
       id: "rdp",
       auto_correct: true

    # Memory and CPU
    config.vm.provider "virtualbox" do |v|
        v.memory = 4096
        v.cpus = 2
    end
 
$install_choco = <<'INSTALL_CHOCO'
$ChocoInstallPath = "$env:SystemDrive\ProgramData\Chocolatey\bin"

if (!(Test-Path $ChocoInstallPath)) {
  iex ((new-object net.webclient).DownloadString('https://chocolatey.org/install.ps1'))
}
INSTALL_CHOCO

$install_devtools = <<'INSTALL_DEVTOOLS'
chocolatey feature enable -n=allowGlobalConfirmation
choco install visualstudiocode
choco install googlechrome
choco install git.install
chocolatey feature disable -n=allowGlobalConfirmation
INSTALL_DEVTOOLS

    config.vm.provision "shell" , inline: $install_choco
    config.vm.provision "shell" , inline: $install_devtools

end        