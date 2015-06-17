include apt
class mono {
  package { "mono-devel" :
  ensure => "installed"
  }
  package { "mono-gmcs" :
  ensure => "installed"
  }
  package { "mono-vbnc" :
  ensure => "installed"
  }
}
