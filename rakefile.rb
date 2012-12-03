require 'rake'
require 'albacore'

task :default => [:build]
task :deploy => [:release]

desc "Building the solution in .Net 4.0"
msbuild :build do |msb|
	msb.properties :configuration => :Debug
	msb.targets :Clean, :Build
	msb.verbosity = 'quiet'
	msb.solution = "src/WTFDTMG.sln"
end

desc "Building Release"
msbuild :release do |msb|
	msb.properties :configuration => :Release
	msb.targets :Clean, :Build
	msb.verbosity = 'quiet'
	msb.solution = "src/WTFDTMG.sln"
end
