# Composer - Init


# Composer --Prefer

/** --prefer-dist and --prefer-source are the two options of composer which included in various documentations with a lack of proper explanation. */

# --prefer-dist 
// Would try to download and unzip archives of the dependencies using GitHub or another API when available. 
// This is used for faster downloading of dependencies in most cases.

# --prefer-source
// Would try to clone and keep the whole VCS repository of the dependencies when available. 
// This is useful when you want to have the original VCS repositories cloned in your vendor/ folder. 