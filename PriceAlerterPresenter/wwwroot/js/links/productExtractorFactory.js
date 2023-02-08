const factoriesMatcher = {
  "remixshop": extractRemixProduct 
}

function extractRemixProduct(url) {
  return true
}

const productExtractorFactory = (url) => {
  const domain = extractDomain(url);
  if (factoriesMatcher.hasOwnProperty(domain)) {
    return factoriesMatcher[domain](url);
  }
};

function extractDomain(url) {
  return url.split(':').find(x => !x.includes('http')).split('.').find(x => !x.includes('www')).replaceAll("/", "").toLowerCase();
}

export default productExtractorFactory;