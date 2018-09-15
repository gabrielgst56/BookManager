const proxy = [
    {
      context: '/api',
      target: 'http://localhost:55504/',
      pathRewrite: {'^/api' : ''}
    }
  ];
  module.exports = proxy;
  