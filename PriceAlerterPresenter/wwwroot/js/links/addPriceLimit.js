import productExtractorFactory from './productExtractorFactory.js';


const urlInput = document.getElementById('urlInput');
const priceParameters = document.getElementById('priceParameters');
const invalidDomain = document.getElementById('invalidDomain');

function processLink(e) {
  try {
    new URL(e.target.value);
    const product = productExtractorFactory(e.target.value);
    if (!product) {
      invalidDomain.classList.remove('hidden');
      return;
    }
    console.log(product);
    priceParameters.classList.remove('hidden')
  } catch (_) {
    priceParameters.classList.add('hidden')
    invalidDomain.classList.add('hidden');
  }
}

urlInput.addEventListener('input', processLink);
urlInput.addEventListener('keyup', (e) => {
  if (e.key === 'Enter') {
    processLink(e);
  }
});
urlInput.addEventListener('blur', processLink);