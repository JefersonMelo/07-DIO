(() => {
    let input = '';
    let taxToPay;
    let routes, visited, previousRoutes;
  
    input = gets();
  
    if (!input || input === '') return false;
  
    const [nCities, cargo] = input.match(/\d+/g);
  
    taxToPay = gets().match(/\d+/g);
  
    if (taxToPay.length > nCities || taxToPay.length < 1) return false;
    taxToPay = taxToPay.map(v => parseInt(v));
  
    if (taxToPay.some(v => (v < 0 || v > 100))) return false;
    taxToPay.unshift(0);
  
    visited = Array.from(new Array(1 * nCities + 1), v => false);
    previousRoutes = Array.from(new Array(1 * nCities + 1), v => 0);
    routes = Array.from(new Array(1 * nCities + 1), v => [])
  
    for (let index = 1; index < nCities; index++) {
      let [from, to, distance] = gets().match(/\d+/g);
  
      if (distance < 1 || distance > 100) return false;
  
      routes[from].push({ to: to * 1, distance: distance * 1 });
      routes[to].push({ to: from * 1, distance: distance * 1 });
    }
  
    let fiefdom = 1;
    let stack = [];
    let nodes = [];
  
    stack = [...stack, fiefdom];
    visited[fiefdom] = true;
    previousRoutes[fiefdom] = -1;
  
    while (stack.length > 0) {
      let v = stack.pop();
  
      for (const route of routes[v]) {
        if (visited[route.to]) continue;
  
        visited[v] = true;
        previousRoutes[route.to] = v
        stack = [...stack, route.to];
      }
  
      if (v !== 1) {
        nodes = [...nodes, v]
      }
    }
  
    let totalDistance = Number(0);
  
    while (nodes.length > 0) {
      let d = -1;
      let v = nodes.pop();
  
      for (let index = 0; index < routes[previousRoutes[v]].length; ++index) {
        const route = routes[previousRoutes[v]][index];
  
        if (route.to === v) {
          d = route.distance;
          break;
        }
      }
      let mover = Number(0);
  
      mover = Math.ceil(parseFloat(Number(taxToPay[v]) / Number(cargo))) * (2 * Number(d));
      totalDistance += mover;
      taxToPay[previousRoutes[v]] += taxToPay[v];
    }
    console.log(totalDistance.toString());
  })();