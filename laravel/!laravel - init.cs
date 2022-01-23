# Laravel - Init


# Composer --Prefer

/** --prefer-dist and --prefer-source are the two options of composer which included in various documentations with a lack of proper explanation. */

# --prefer-dist 
// Would try to download and unzip archives of the dependencies using GitHub or another API when available. 
// This is used for faster downloading of dependencies in most cases.

# --prefer-source
// Would try to clone and keep the whole VCS repository of the dependencies when available. 
// This is useful when you want to have the original VCS repositories cloned in your vendor/ folder. 


--------------------

# Installing a specific version

// specific major version
$ composer create-project --prefer-dist laravel/laravel:5.8 .

// specific minor version
$ composer create-project --prefer-dist laravel/laravel:5.8.1 .

// latest major version
$ composer create-project --prefer-dist laravel/laravel:5.* .

// latest minor version
$ composer create-project --prefer-dist laravel/laravel:5.8.* .

--------------------

# Upgrading or Downgrading to a specific version

// Update your composer.json file with the desired version of laravel. 
// Also, check if your desired version requires a specific PHP version to run it.

"require": {
   "php": "^7.2",
   "laravel/framework": "5.8.*",
},

//  Now, delete your vendor folder and composer.lock file inside your project folder.

$ composer install

--------------------