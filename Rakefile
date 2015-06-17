require 'bundler/setup'
require 'rake/clean'
require 'albacore'
require 'open-uri'
require 'fileutils'
require 'os'
require 'nokogiri'
import 'assets/tools.rake'


PACKAGES = File.expand_path("packages")
TOOLS = File.expand_path("tools")
NUGET = File.expand_path("#{TOOLS}/nuget")
Configuration = ENV['CONFIGURATION'] || 'Release'

desc 'retrieve dependencies'
task :retrieve => ['tools:nuget_fetch']

desc 'build the project'
task :build => [:compile]

desc 'Run the tests'
task :test => [:nunit]

desc 'Retrieve, Build, Test'
task :preflight => [:retrieve, :build, :test]



build :compile  => ['tools:nuget_fetch'] do |b|
  b.prop 'Configuration', Configuration
  b.sln = 'Untappd.Net.sln'
end

task :tp do
  puts NUNIT
end

test_runner :nunit do |tests|
  tests.files = FileList["src/**/*UnitTests/bin/#{Configuration}/*UnitTests.dll"] # dll files with test
  tests.exe = "packages/NUnit.Runners.2.6.4/tools/nunit-console.exe" # executable to run tests with
end

# task :tests => :'tests:unit'

#task :ensure_nuget_key do
#  raise 'missing env NUGET_KEY value' unless ENV['NUGET_KEY']
#end

#Albacore::Tasks::Release.new :release,
#                             pkg_dir: 'build/pkg',
#                             depend_on: [:create_nugets, :ensure_nuget_key],
#                             nuget_exe: 'packages/NuGet.CommandLine/tools/NuGet.exe',
#                             api_key: ENV['NUGET_KEY']
